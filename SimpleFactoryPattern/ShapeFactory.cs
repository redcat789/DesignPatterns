﻿using SimpleFactoryPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = SimpleFactoryPattern.Shapes.Rectangle;

namespace SimpleFactoryPattern
{
    public class ShapeFactory
    {
        public static Shape CreateShape(string type)
        {
            return type switch
            {
                "circle" => new Circle(),
                "rectangle" => new Rectangle(),
                _ => throw new ArgumentException("Invalid shape type"),
            };
        }
    }
}
