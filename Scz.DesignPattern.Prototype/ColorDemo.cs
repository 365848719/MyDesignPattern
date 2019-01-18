using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Prototype
{
    [Serializable]
    public class RedColor : IColorDemo
    {
        public int Blue
        {
            get;
            set;         
        }

        public int Green
        {
            get;
            set;
        }       

        public int Red
        {
            get;
            set;
        }

        public ColorPicker Picker
        {
            get; set;
        }

        public string Name { get ; set ; }

        public IColorDemo Clone()
        {
            return this.MemberwiseClone() as IColorDemo;
        }

        public object DeepClone()
        {
            string target = SerializableHelper.Serializable(this);
            return SerializableHelper.Derializable<IColorDemo>(target);
        }
              
    }
}