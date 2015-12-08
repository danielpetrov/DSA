using System;
using System.Collections.Generic;
// REFERENCE copy - paste from Doncho solution 2014
namespace UnitsOfWork
{
    public enum CommandType
    {
        End,
        Add,
        Remove,
        Find,
        Power
    }

    public class Command
    {
        public string Params { get; set; }

        public static Dictionary<string, CommandType> stringToCommandType;

        static Command()
        {
            stringToCommandType = new Dictionary<string, CommandType>();
            stringToCommandType["add"] = CommandType.Add;
            stringToCommandType["end"] = CommandType.End;
            stringToCommandType["remove"] = CommandType.Remove;
            stringToCommandType["find"] = CommandType.Find;
            stringToCommandType["power"] = CommandType.Power;
        }

        public CommandType Type { get; set; }

        public static Command ParseCommand(string input)
        {
            foreach (var pair in stringToCommandType)
            {
                if (input.StartsWith(pair.Key))
                {
                    return new Command()
                    {
                        Type = pair.Value,
                        Params = input.Substring(pair.Key.Length).Trim()
                    };
                }
            }
            return null;
        }
    }
}