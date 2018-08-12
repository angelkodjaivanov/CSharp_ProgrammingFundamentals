using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Program
    {

        class Robot 
        {
            public Head Head { get; set; }
            public Torso Torso { get; set; }
            public Arm Arms { get; set; }
            public Arm SecondArm { get; set; }
            public Leg FirstLeg { get; set; }
            public Leg SecondLeg { get; set; }
        }

        static void Main(string[] args)
        {
            long maxEnergy = long.Parse(Console.ReadLine());
            long robotEnergy = 0;
            string input = Console.ReadLine();
            Robot robot = new Robot();
            bool hasGotHead = false, hasGotTorso = false, hasGotLegs = false, hasGotArms = false;
            int inputLegs = 0, inputArms = 0;

            while (input != "Assemble!")
            {

                List<string> robotPartProp = input.Split(' ').ToList();

                switch (robotPartProp[0])
                {
                    case "Head":
                        hasGotHead = true;

                        robot.Head.EnergyConsumation = int.Parse(robotPartProp[1]);
                        robot.Head.IQ = int.Parse(robotPartProp[1]);
                        robot.Head.SkinMaterial = robotPartProp[2];
                        robotEnergy += int.Parse(robotPartProp[1]);

                        break;
                    case "Torso":
                        hasGotTorso = true;

                        robot.Torso.EnergyConsumation = int.Parse(robotPartProp[1]);
                        robot.Torso.ProcessorSizeInCentimeters = double.Parse(robotPartProp[2]);
                        robot.Torso.HousingMaterial = robotPartProp[3];
                        robotEnergy += int.Parse(robotPartProp[1]);

                        break;
                    case "Arm":
                        inputArms++;
                        if (inputArms == 1)
                        {
                            robot.Arms.EnergyConsumation = int.Parse(robotPartProp[1]);
                            robot.Arms.ArmReachDistance = int.Parse(robotPartProp[2]);
                            robot.Arms.CountOfFingers = int.Parse(robotPartProp[3]);
                            robotEnergy += int.Parse(robotPartProp[1]);
                        }
                        else if (inputArms == 2)
                        {
                            robot.SecondArm.EnergyConsumation = int.Parse(robotPartProp[1]);
                            robot.SecondArm.ArmReachDistance = int.Parse(robotPartProp[2]);
                            robot.SecondArm.CountOfFingers = int.Parse(robotPartProp[3]);
                            robotEnergy += int.Parse(robotPartProp[1]);
                            hasGotArms = true;
                        }
                        else
                        {

                        }
                        break;
                    case "Leg":
                        inputLegs++;
                        if (inputLegs == 1)
                        {
                            robot.FirstLeg.EnergyConsumation = int.Parse(robotPartProp[1]);
                            robot.FirstLeg.Strength = int.Parse(robotPartProp[2]);
                            robot.FirstLeg.Speed = int.Parse(robotPartProp[3]);
                            robotEnergy += int.Parse(robotPartProp[1]);
                        }
                        else if (inputLegs == 2)
                        {
                            robot.SecondLeg.EnergyConsumation = int.Parse(robotPartProp[1]);
                            robot.SecondLeg.Strength = int.Parse(robotPartProp[2]);
                            robot.SecondLeg.Speed = int.Parse(robotPartProp[3]);
                            robotEnergy += int.Parse(robotPartProp[1]);
                            hasGotLegs = true;
                        }
                        else
                        {

                        }
                        break;
                }

                input = Console.ReadLine();
            }

            if (hasGotArms && hasGotHead && hasGotTorso && hasGotLegs)
            {
                if (robotEnergy <= maxEnergy)
                {

                }
                else
                {
                    Console.WriteLine("We need more power!");
                }
            }
            else
            {
                Console.WriteLine("We need more parts!");
            }

        }

        class Head
        {
            public int EnergyConsumation { get; set; }
            public int IQ { get; set; }
            public string SkinMaterial { get; set; }
        }

        class Torso
        {
            public int EnergyConsumation { get; set; }
            public double ProcessorSizeInCentimeters { get; set; }
            public string HousingMaterial { get; set; }
        }

        class Arm
        {
            public int EnergyConsumation { get; set; }
            public int ArmReachDistance { get; set; }
            public int CountOfFingers { get; set; }
        }

        class Leg
        {
            public int EnergyConsumation { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }
        }
    }
}
