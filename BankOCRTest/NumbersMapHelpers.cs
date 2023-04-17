﻿namespace BankOCRTest
{
    internal static class NumbersMapHelpers
    {
        public static readonly Dictionary<int, string> digitMap = new Dictionary<int, string>()
            {
                {0,
                 " _ " +
                 "| |" +
                 "|_|"},
                {1,
                 "   " +
                 "  |" +
                 "  |"},
                {2,
                 " _ " +
                 " _|" +
                 "|_ "},
                {3,
                 " _ " +
                 " _|" +
                 " _|"},
                {4,
                 "   " +
                 "|_|" +
                 "  |"},
                {5,
                 " _ " +
                 "|_ " +
                 " _|"},
                {6,
                 " _ " +
                 "|_ " +
                 "|_|"},
                {7,
                 " _ " +
                 "  |" +
                 "  |"},
                {8,
                 " _ " +
                 "|_|" +
                 "|_|"},
                {9,
                 " _ " +
                 "|_|" +
                 " _|"}
            };

        public static readonly Dictionary<int, string> digitsLineMap = new Dictionary<int, string>()
        {
            {0,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            "| || || || || || || || || |\r\n" +
            "|_||_||_||_||_||_||_||_||_|\r\n" +
            "                           \r\n"},
            {1,
            "                           \r\n" +
            "  |  |  |  |  |  |  |  |  |\r\n" +
            "  |  |  |  |  |  |  |  |  |\r\n" +
            "                           \r\n"},
            {2,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            " _| _| _| _| _| _| _| _| _|\r\n" +
            "|_ |_ |_ |_ |_ |_ |_ |_ |_ \r\n" +
            "                           \r\n"},
            {3,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            " _| _| _| _| _| _| _| _| _|\r\n" +
            " _| _| _| _| _| _| _| _| _|\r\n" +
            "                           \r\n"},
            {4,
            "                           \r\n" +
            "|_||_||_||_||_||_||_||_||_|\r\n" +
            "  |  |  |  |  |  |  |  |  |\r\n" +
            "                           \r\n"},
            {5,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            "|_ |_ |_ |_ |_ |_ |_ |_ |_ \r\n" +
            " _| _| _| _| _| _| _| _| _|\r\n" +
            "                           \r\n"},
            {6,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            "|_ |_ |_ |_ |_ |_ |_ |_ |_ \r\n" +
            "|_||_||_||_||_||_||_||_||_|\r\n" +
            "                           \r\n"},
            {7,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            "  |  |  |  |  |  |  |  |  |\r\n" +
            "  |  |  |  |  |  |  |  |  |\r\n" +
            "                           \r\n"},
            {8,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            "|_||_||_||_||_||_||_||_||_|\r\n" +
            "|_||_||_||_||_||_||_||_||_|\r\n" +
            "                           \r\n"},
            {9,
            " _  _  _  _  _  _  _  _  _ \r\n" +
            "|_||_||_||_||_||_||_||_||_|\r\n" +
            " _| _| _| _| _| _| _| _| _|\r\n" +
            "                           \r\n"}
        };

        public static readonly Dictionary<int, string> outputNumbers = new Dictionary<int, string>()
        {
            {0, "000000000"},
            {1, "111111111"},
            {2, "222222222"},
            {3, "333333333"},
            {4, "444444444"},
            {5, "555555555"},
            {6, "666666666"},
            {7, "777777777"},
            {8, "888888888"},
            {9, "999999999"}
        };
    }
}