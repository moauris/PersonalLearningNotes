using System;
using System.IO;
using System.Text;

namespace GenDiaryTemp
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder headerMessageBuilder = new StringBuilder();
            headerMessageBuilder.Append("\tGenerating Diary Template for ");
            headerMessageBuilder.Append(DateTime.Today.ToString("yyyy-MM-dd"));

            Console.WriteLine(headerMessageBuilder.ToString());

            Console.WriteLine("\tPerforming Step 1: Checking duplicate templates");
            string currentDir = Directory.GetCurrentDirectory() + '\\';
            string todaysFileName = currentDir + DateTime.Today.ToString("yyyy_MM_dd") + "_Learning_Diary.MD";
            FileInfo todaysFileInfo = new FileInfo(todaysFileName);
            if (todaysFileInfo.Exists)
            {
                Console.Write(todaysFileInfo.FullName);
                Console.WriteLine(" already exists. Exiting.");
                return;
            }
            Console.WriteLine("\tPerforming Step 2: Creating new File");
            using (StreamWriter sw = new StreamWriter(todaysFileName))
            {
                string templateContent = @"
[toc]

# Overview: Today's tasks and fulfillment

- [ ] Task 1
- [ ] Task 2
- [ ] Task 3

# Topic 1:

## Summary

## Problem

## Solution

## Extra

# Topic 2:

## Summary

## Problem

## Solution

## Extra

# Topic 3:

## Summary

## Problem

## Solution

## Extra";

                Console.WriteLine("\tPerforming Step 3: Applying Template");
                sw.Write(templateContent);
                
            }
            StringBuilder endMessageBuilder = new StringBuilder();
            endMessageBuilder.AppendLine("\tFile Created:");
            endMessageBuilder.AppendLine(todaysFileInfo.FullName);
            //endMessageBuilder.AppendLine(todaysFileInfo.Length.ToString() + 'B');
            //endMessageBuilder.AppendLine("LastWrite: " + todaysFileInfo.LastWriteTime.ToLongTimeString());
            Console.WriteLine(endMessageBuilder.ToString());
            Console.WriteLine("\tPerforming Step 4: Program ends. Exiting.");
        }
    }
}