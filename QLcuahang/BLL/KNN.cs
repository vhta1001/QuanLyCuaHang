﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace BLL
{
    public class KNN
    {
        private int lines;

        // this holds the values of the training data
        private List<double[]>   trainingSetValues = new List<double[]>();
        // this holds the class associated with the values
        private List<string>     trainingSetClasses = new List<string>();

        // same for the test input
        private List<double[]>   testSetValues = new List<double[]>();
        private List<string>     testSetClasses = new List<string>();
        
        private int K;

        public enum DataType
        {
            TRAININGDATA, TESTDATA
        };
        public void LoadDatastring(string test, DataType dataType)
        {
            this.testSetClasses.Clear();
            this.testSetValues.Clear();

            // Console.WriteLine("[i] reading data from {0} ...", path);

            
                // as we have a CSV file basically, split the line at each ','
                string[] splitLine = test.Split(',').ToArray();

                // and add them to a list
                List<string> lineItems = new List<string>(splitLine.Length);
                lineItems.AddRange(splitLine);

                // create an appropiate array to hold the doubles from this line
                double[] lineDoubles = new double[lineItems.Count - 1];
                // and a string holding the class
                string lineClass = lineItems.ElementAt(lineItems.Count - 1);

                for (int i = 0; i < lineItems.Count - 1; i++)    // last item is the set class
                {
                    // convert each item in the list to a double
                    double val = Double.Parse(lineItems.ElementAt(i));
                    lineDoubles[i] = val;
                }

                // finally, save them

                if (dataType == DataType.TRAININGDATA)
                {
                    this.trainingSetValues.Add(lineDoubles);
                    this.trainingSetClasses.Add(lineClass);
                }
                else if (dataType == DataType.TESTDATA)
                {
                    this.testSetValues.Add(lineDoubles);
                    this.testSetClasses.Add(lineClass);
                }
                this.lines++;
            

            //Console.WriteLine("[+] done. read {0} lines.", this.lines);

           
        }
        public List<string> Classify1(int neighborsNumber)
        {
            this.K = neighborsNumber;
            List<string> kq = new List<string>();
            // create an array where we store the distance from our test data and the training data -> [0]
            // plus the index of the training data element -> [1]
            double[][] distances = new double[trainingSetValues.Count][];

            //double accuracy = 0;
            double correct = 0, testNumber = 0;

            for (int i = 0; i < trainingSetValues.Count; i++)
                distances[i] = new double[2];

            //Console.WriteLine("[i] classifying...");

            // start computing
            for (var test = 0; test < this.testSetValues.Count; test++)
            {
                Parallel.For(0, trainingSetValues.Count, index =>
                {
                    var dist = EuclideanDistance(this.testSetValues[test], this.trainingSetValues[index]);
                    distances[index][0] = dist;
                    distances[index][1] = index;
                }
                );

                //Console.WriteLine("[+] closest K={0} neighbors: ", this.K);

                // sort and select first K of them
                var sortedDistances = distances.AsParallel().OrderBy(t => t[0]).Take(this.K);

                string realClass = testSetClasses[test];

                // print and check the result
                foreach (var d in sortedDistances)
                {
                    string predictedClass = trainingSetClasses[(int)d[1]];
                    kq.Add(predictedClass);
                    if (string.Equals(realClass, predictedClass) == true)
                        correct++;
                    testNumber++;
                    //Console.WriteLine("[>>>] test {0}: real class: {1} predicted class: {2}", test, realClass, predictedClass);
                }
            }

           // Console.WriteLine();

            // compute and print the accuracy
            //accuracy = (correct / testNumber) * 100;
            //Console.WriteLine("[i] accuracy: {0}%", accuracy);
            return kq;

        }
        public void LoadData(string path, DataType dataType)
        {
            StreamReader file = new StreamReader(path);
            string line;

            this.lines = 0;

           // Console.WriteLine("[i] reading data from {0} ...", path);

            while((line = file.ReadLine()) != null)
            {
                // as we have a CSV file basically, split the line at each ','
                string[] splitLine = line.Split(',').ToArray();

                // and add them to a list
                List<string> lineItems = new List<string>(splitLine.Length);           
                lineItems.AddRange(splitLine);

                // create an appropiate array to hold the doubles from this line
                double[] lineDoubles = new double[lineItems.Count - 1];
                // and a string holding the class
                string lineClass = lineItems.ElementAt(lineItems.Count - 1);

                for(int i = 0; i < lineItems.Count - 1; i++)    // last item is the set class
                {
                    // convert each item in the list to a double
                    double val = Double.Parse(lineItems.ElementAt(i));
                    lineDoubles[i] = val;
                }

                // finally, save them

                if (dataType == DataType.TRAININGDATA)
                {
                    this.trainingSetValues.Add(lineDoubles);
                    this.trainingSetClasses.Add(lineClass);
                }
                else if(dataType == DataType.TESTDATA)
                {
                    this.testSetValues.Add(lineDoubles);
                    this.testSetClasses.Add(lineClass);
                }
                this.lines++;
            }

            //Console.WriteLine("[+] done. read {0} lines.", this.lines);

            file.Close();
        }

        public void Classify(int neighborsNumber)
        {
            this.K = neighborsNumber;

            // create an array where we store the distance from our test data and the training data -> [0]
            // plus the index of the training data element -> [1]
            double[][] distances = new double[trainingSetValues.Count][];

            double accuracy = 0;
            double correct = 0, testNumber = 0;

            for (int i = 0; i < trainingSetValues.Count; i++)
                distances[i] = new double[2];

            Console.WriteLine("[i] classifying...");

            // start computing
            for(var test = 0; test < this.testSetValues.Count; test++)
            {
                Parallel.For(0, trainingSetValues.Count, index =>
                    {
                        var dist = EuclideanDistance(this.testSetValues[test], this.trainingSetValues[index]);
                        distances[index][0] = dist;
                        distances[index][1] = index;
                    }
                );

                Console.WriteLine("[+] closest K={0} neighbors: ", this.K);

                // sort and select first K of them
                var sortedDistances = distances.AsParallel().OrderBy(t => t[0]).Take(this.K);

                string realClass = testSetClasses[test];

                // print and check the result
                foreach (var d in sortedDistances)
                {
                    string predictedClass = trainingSetClasses[(int) d[1]];
                    if (string.Equals(realClass, predictedClass) == true)
                        correct++;
                    testNumber++;
                    Console.WriteLine("[>>>] test {0}: real class: {1} predicted class: {2}", test, realClass, predictedClass);
                }
            }

            Console.WriteLine();

            // compute and print the accuracy
            accuracy = (correct / testNumber) * 100;
            Console.WriteLine("[i] accuracy: {0}%", accuracy);

        }

        private static double EuclideanDistance(double[] sampleOne, double[] sampleTwo)
        {
            double d = 0.0;

            for(int i = 0; i < sampleOne.Length; i++)
            {
                double temp = sampleOne[i] - sampleTwo[i];
                d += temp * temp;
            }
            return Math.Sqrt(d);
        }
    }
}
