using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis_SoftUniCode
{
    class Program
    {
        class Jarvis
        {
            public long Energy { get; set; }
            public Head Head { get; set; }
            public Torso Torso { get; set; }
            public List<Arm> Arms { get; set; }
            public List<Leg> Legs { get; set; }


            public void addHead(Head headInput)
            {
                if (Head == null)
                {
                    Head = headInput;
                }
                if (headInput.EnergyConsumation < Head.EnergyConsumation)
                {
                    Head = headInput;
                }
            }
            public void addTorso(Torso torsoInput)
            {
                if (Torso == null)
                {
                    Torso = torsoInput;
                }
                if (torsoInput.EnergyConsumation < Torso.EnergyConsumation)
                {
                    Torso = torsoInput;
                }
            }
            public void addArm(Arm armInput)
            {
                if (Arms == null)
                {
                    Arms = new List<Arm>();
                }
                if (Arms.Count < 2)
                {
                    Arms.Add(armInput);
                }
                else
                { 
                    for (int i = 0; i < this.Arms.Count; i++)
                    {
                        if (Arms[i].EnergyConsumation > armInput.EnergyConsumation)
                        {
                            Arms.RemoveAt(i);
                            Arms.Add(armInput);
                        }
                    }
                }
            }

            public void addLeg(Leg leg)
            {
                if(Legs == null)
                {
                    Legs = new List<Leg>();
                }
                if (Legs.Count < 2)
                {
                    Legs.Add(leg);
                }
                else
                {
                    for (int i = 0; i < this.Legs.Count; i++)
                    {
                        if (Legs[i].EnergyConsumation > leg.EnergyConsumation)
                        {
                            Legs.RemoveAt(i);
                            Legs.Add(leg);
                        }
                    }
                }
            }
            public override string ToString()
            {
                if (Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
                {
                    return "We need more parts!";
                }

                long totalEnergy = 0L;
                totalEnergy += Head.EnergyConsumation;
                totalEnergy += Torso.EnergyConsumation;
                totalEnergy += Arms.Select(a => a.EnergyConsumation).Sum();
                totalEnergy += Legs.Select(a => a.EnergyConsumation).Sum();

                if(totalEnergy > Energy)
                {
                    return "We need more power!";
                }

                StringBuilder sb = new StringBuilder();

                sb.Append("Jarvis:\r\n");
                sb.Append(Head.ToString());
                sb.Append(Torso.ToString());

                foreach (Arm arm in Arms.OrderBy(a => a.EnergyConsumation))
                {
                    sb.Append(arm.ToString());
                }

                foreach (Leg leg in Legs.OrderBy(a => a.EnergyConsumation))
                {
                    sb.Append(leg.ToString());
                }

                return sb.ToString();
            }

        }

        static void Main(string[] args)
        {
            long energy = long.Parse(Console.ReadLine());
            Jarvis jarvis = new Jarvis();
            jarvis.Energy = energy;

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                if (tokens[0] == "Assemble!")
                {
                    break;
                }

                switch (tokens[0])
                {
                    case "Head":
                        Head head = new Head()
                        {
                            EnergyConsumation = int.Parse(tokens[1]),
                            IQ = int.Parse(tokens[2]),
                            SkinMaterial = tokens[3]
                        };
                        jarvis.addHead(head);
                        break;
                    case "Torso":
                        Torso torso = new Torso()
                        {
                            EnergyConsumation = int.Parse(tokens[1]),
                            ProcessorSizeInCentimeters = double.Parse(tokens[2]),
                            HousingMaterial = tokens[3]
                        };
                        jarvis.addTorso(torso);
                        break;
                    case "Leg":
                        Leg leg = new Leg()
                        {
                            EnergyConsumation = int.Parse(tokens[1]),
                            Strength = int.Parse(tokens[2]),
                            Speed = int.Parse(tokens[3])
                        };
                        jarvis.addLeg(leg);
                        break;
                    case "Arm":
                        Arm arm = new Arm()
                        {
                            EnergyConsumation = int.Parse(tokens[1]),
                            ArmReachDistance = int.Parse(tokens[2]),
                            CountOfFingers = int.Parse(tokens[3])
                        };
                        jarvis.addArm(arm);
                        break;
                };

            }
            Console.WriteLine(jarvis.ToString());

        }

        class Head
        {
            public int EnergyConsumation { get; set; }
            public int IQ { get; set; }
            public string SkinMaterial { get; set; }

            public override string ToString()
            {
                String result = String.Empty;
                result += "#Head:\r\n";
                result += string.Format($"###Energy consumption: {EnergyConsumation}\r\n");
                result += string.Format($"###IQ: {IQ}\r\n");
                result += string.Format($"###Skin material: {SkinMaterial}\r\n");

                return result;
            }
        }

        class Torso
        {
            public int EnergyConsumation { get; set; }
            public double ProcessorSizeInCentimeters { get; set; }
            public string HousingMaterial { get; set; }

            public override string ToString()
            {
                String result = String.Empty;
                result += "#Torso:\r\n";
                result += string.Format($"###Energy consumption: {EnergyConsumation}\r\n");
                result += string.Format($"###Processor size: {ProcessorSizeInCentimeters:F1}\r\n");
                result += string.Format($"###Corpus material: {HousingMaterial}\r\n");

                return result;
            }
        }

        class Arm
        {
            public int EnergyConsumation { get; set; }
            public int ArmReachDistance { get; set; }
            public int CountOfFingers { get; set; }

            public override string ToString()
            {
                String result = String.Empty;
                result += "#Arm:\r\n";
                result += string.Format($"###Energy consumption: {EnergyConsumation}\r\n");
                result += string.Format($"###Reach: {ArmReachDistance}\r\n");
                result += string.Format($"###Fingers: {CountOfFingers}\r\n");

                return result;
            }
        }

        class Leg
        {
            public int EnergyConsumation { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }

            public override string ToString()
            {
                String result = String.Empty;
                result += "#Leg:\r\n";
                result += string.Format($"###Energy consumption: {EnergyConsumation}\r\n");
                result += string.Format($"###Strength: {Strength}\r\n");
                result += string.Format($"###Speed: {Speed}\r\n");

                return result;
            }
        }


    }
}
