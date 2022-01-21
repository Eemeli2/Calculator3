using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Oma_Projekti_1.ViewModels
{
    public enum Operation
    {
        Deduct,
        Add,
        Divide,
        Multiply
    }

    public class MainViewModel : BaseViewModel
    {
        private double? a;
        private double? b;
        private double? sum;
        private Command calculateCommand;

        private Operation selectedOperation;

        public MainViewModel()
        {
            calculateCommand = new Command(
                () =>
                {
                    switch (SelectedOperation)
                    {
                        case Operation.Divide:
                            Divide = a / b;
                            break;

                        case Operation.Add:
                            Divide = b + a;
                            break;

                        case Operation.Deduct:
                            Divide = b - a;
                            break;

                        case Operation.Multiply:
                            Divide = b * a;
                            break;


                        default:
                            break;
                    }
                },
                () => 
                {
                    bool canExecute = false;
                    switch (SelectedOperation)
                    {
                        case Operation.Divide:
                            canExecute = a.HasValue && b.HasValue && b.Value != 0;
                            break;

                        case Operation.Add:
                        case Operation.Deduct:
                        case Operation.Multiply:
                        default:
                            canExecute = a.HasValue && b.HasValue;
                            break;
                    }
                    return canExecute;
                });


        }

        
        public Operation SelectedOperation
        {
            get => selectedOperation;
            set
            {
                if (SetProperty(ref selectedOperation, value))
                {
                    calculateCommand.ChangeCanExecute();
                }
            }
        }

        public IEnumerable<Operation> Operations => new[] { Operation.Divide, Operation.Deduct, Operation.Multiply, Operation.Add };


        public double? A
        {
            get => a;
            set
            {
                if (SetProperty(ref a, value)) calculateCommand.ChangeCanExecute();
            }
        }

        public double? B
        {
            get => b;
            set
            {
                if (SetProperty(ref b, value)) calculateCommand.ChangeCanExecute();
            }
        }

        public double? Divide { get => sum; set => SetProperty(ref sum, value);}
        public Command CalculateCommand => calculateCommand;
    }
}
