﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace MLModel1_ConsoleApp1
{
    public partial class MLModel1
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"Country or Area", @"Country or Area"),new InputOutputColumnPair(@"Area", @"Area"),new InputOutputColumnPair(@"Record Type", @"Record Type"),new InputOutputColumnPair(@"Reliability", @"Reliability")})      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(@"Year", @"Year"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Month", @"Month"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Country or Area",@"Area",@"Record Type",@"Reliability",@"Year",@"Month"}))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.Regression.Trainers.Sdca(l1Regularization:4.36435463671038F,l2Regularization:0.417710836431446F,labelColumnName:@"Number_of_Births",featureColumnName:@"Features"));

            return pipeline;
        }
    }
}