using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lb17
{
    abstract class MethodsTeacher
    {
        public abstract void SetMark();
        public abstract void SetCharacterist();
        public abstract void GetEveragy();
    }
    interface InewCourse
    {
        void enroll_Course();
    }
    interface IMath
    {
        void Move();
    }
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
