using System;
using System.Collections.Generic;

namespace TextEditorUndoRedo
{
    class Program
    {
        static void Main()
        {
            // Stack for Undo
            Stack<string> undoStack = new Stack<string>();

            // Stack for Redo (Bonus)
            Stack<string> redoStack = new Stack<string>();

            // Push actions
            undoStack.Push("Type A");
            undoStack.Push("Type B");
            undoStack.Push("Delete B");
            undoStack.Push("Type C");
            undoStack.Push("Type D");

            Console.WriteLine("---- All Actions ----");
            foreach (var action in undoStack)
            {
                Console.WriteLine(action);
            }

            // Undo last 3 actions
            Console.WriteLine("\n---- Undo Last 3 Actions ----");
            for (int i = 0; i < 3; i++)
            {
                if (undoStack.Count > 0)
                {
                    string undoneAction = undoStack.Pop();
                    redoStack.Push(undoneAction); // store for redo
                    Console.WriteLine("Undo: " + undoneAction);
                }
            }

            // Peek current action
            Console.WriteLine("\n---- Current Top Action ----");
            if (undoStack.Count > 0)
                Console.WriteLine("Top Action: " + undoStack.Peek());

            // Bonus: Redo last 2 actions
            Console.WriteLine("\n---- Redo Last 2 Actions ----");
            for (int i = 0; i < 2; i++)
            {
                if (redoStack.Count > 0)
                {
                    string redoAction = redoStack.Pop();
                    undoStack.Push(redoAction);
                    Console.WriteLine("Redo: " + redoAction);
                }
            }

            // Final State
            Console.WriteLine("\n---- Final Actions in Undo Stack ----");
            foreach (var action in undoStack)
            {
                Console.WriteLine(action);
            }
        }
    }
}