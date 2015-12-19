using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Ink;

namespace MementoPatternExample
{
    public class InkCanvasWithUndo : InkCanvas
    {
        public IMemento CreateMemento()
        {
            Stroke[] copy = Strokes.ToArray();
            return new InkCanvasMemento() { State = copy };
        }

        public void SetMemento(IMemento memento)
        {
            Strokes = new StrokeCollection((Stroke[])memento.State);
        }

        public class InkCanvasMemento : IMemento
        {
            public object State { get; set; }
        }
    }
}
