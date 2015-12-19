using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MementoPatternExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Stack<IMemento> states = new Stack<IMemento>();

        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, OnExecutedCommands));

            InkCanvasWithUndo1.MouseUp += InkCanvasWithUndo1_MouseUp;

            // Initialize with empty state
            StoreState();
        }

        private void InkCanvasWithUndo1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StoreState();
        }

        private void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
        {
            var myWindow = (MainWindow)sender;
            if (e.Command == ApplicationCommands.Undo)
            {
                myWindow.Undo(sender, e);
            }
        }

        private void Undo(object sender, ExecutedRoutedEventArgs e)
        {
            if (states.Count > 1)
            {
                //discard current state
                states.Pop();
                var lastState = states.Peek();
                InkCanvasWithUndo1.SetMemento(lastState);
            }
            label1.Content = states.Count;
        }

        private void StoreState()
        {
            // Save state to Memento
            var memento = InkCanvasWithUndo1.CreateMemento();
            states.Push(memento);
            label1.Content = states.Count;
        }
    }
}
