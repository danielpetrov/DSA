using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitsOfWork
{
    class MainClass
    {
        const string UnitAddedSuccessFormat = "SUCCESS: {0} added!";
        const string UnitAddedErrorFormat = "FAIL: {0} already exists!";
        const string UnitRemovedSuccesFormat = "SUCCESS: {0} removed!";
        const string UnitRemovedErrorFormat = "FAIL: {0} could not be found!";
        const string UnitsFindSuccesFormat = "RESULT: {0}";
        const string UnitsFindErrorFormat = "RESULT: ";
        public static void Main(string[] args)
        {
            var unitsWorkshop = new UnitWorkshop();
            while (true)
            {
                string input = Console.ReadLine();
                var command = Command.ParseCommand(input);
                switch (command.Type)
                {
                    case CommandType.Add:
                        var unit = Unit.ParseUnit(command.Params);
                        var addResult = unitsWorkshop.AddUnit(unit);
                        string format;
                        if (addResult)
                        {
                            format = UnitAddedSuccessFormat;
                        }
                        else
                        {
                            format = UnitAddedErrorFormat;
                        }
                        Console.WriteLine(format, unit.Name);
                        break;
                    case CommandType.Remove:
                        var unitName = new Unit(command.Params);
                        var removeResult = unitsWorkshop.RemoveUnit(unitName);
                        if (removeResult)
                        {
                            format = UnitRemovedSuccesFormat;
                        }
                        else
                        {
                            format = UnitRemovedErrorFormat;
                        }
                        Console.WriteLine(format, unitName.Name);

                        break;
                     case CommandType.Power:
                        var powerUnits = unitsWorkshop.PowerUnits(command.Params);
                        if (powerUnits == null)
                        {
                            Console.WriteLine(UnitsFindErrorFormat, command.Params);
                        }
                        else
                        {
                            Console.WriteLine(UnitsFindSuccesFormat, string.Join(", ", powerUnits));
                        }
                        break;
                      case CommandType.Find:
                          var foundUnits = unitsWorkshop.UnitsByType(command.Params);
                          if (foundUnits == null)
                          {
                              Console.WriteLine(UnitsFindErrorFormat, command.Params);
                          }
                          else
                          {
                              Console.WriteLine(UnitsFindSuccesFormat, string.Join(", ", foundUnits));
                          }
                          break;
                      case CommandType.End:
                          return;
                }
            }
        }
    }
}