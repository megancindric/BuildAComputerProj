using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class Computer
    {
        //case that will contain all other parts

        //member variables
        public HardDrive hardDrive;
        public CPU cpu;
        public GPU gpu;
        public Motherboard motherboard;
        public RAM ram;


        //constructor
        public Computer()
        {
            hardDrive = new HardDrive(100, 100);
            cpu = new CPU("Apple", "MyCPU");
            gpu = new GPU("Apple", 100);
            ram = new RAM(100, "Apple");
            motherboard = new Motherboard("Apple", cpu, ram, hardDrive, gpu);
        }

        //member methods
    }
}
