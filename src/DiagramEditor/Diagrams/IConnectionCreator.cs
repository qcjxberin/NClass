﻿// NClass - Free class diagram editor
// Copyright (C) 2016 Georgi Baychev
// 
// This program is free software; you can redistribute it and/or modify it under 
// the terms of the GNU General Public License as published by the Free Software 
// Foundation; either version 3 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT 
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// this program; if not, write to the Free Software Foundation, Inc., 
// 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System.Drawing;

namespace NClass.DiagramEditor.Diagrams
{
    // TODO: simple marker interface for the connection creator
    // ideally each diagram will have its own connection creator
    // and the Diagram parent class will contain only an IConnectionCreator
    // property. In this way ConnectionCreator may stay internal
    public interface IConnectionCreator
    {
        void MouseDown(AbsoluteMouseEventArgs e);
        void MouseMove(AbsoluteMouseEventArgs e);
        bool Created { get; }
        void Draw(Graphics g);
    }
}