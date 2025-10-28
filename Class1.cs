using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IAnimal
    {
        void MakeSound();
        void Move();
    }

    interface IVehicle
    {
        void Start();
        void Stop();
    }
}