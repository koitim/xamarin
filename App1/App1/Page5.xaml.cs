using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
        private Todo todo = new Todo() { Title = "Título", Notes = "Notas", Completed = true };
        public Page5 ()
		{
			InitializeComponent ();
            this.BindingContext = todo;
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //dynamic obj = this.BindingContext;
            var obj = this.BindingContext as Todo;
            await this.DisplayAlert("Display", obj.Title, "Ok");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            todo.Title = newTitle.Text;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            todo.Notes = todo.Notes + "a";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            todo.Completed = !todo.Completed;
        }
    }

    public class Todo : BindableObject
    {
        private string title;
        private string notes;
        private bool completed;

        private void PropNotify([CallerMemberName] string propName = null)
        {
            this.OnPropertyChanged(propName);
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                //this.OnPropertyChanged("Title");
                this.PropNotify();
            }
        }
        public string Notes
        {
            get { return this.notes; }
            set
            {
                this.notes = value;
                this.PropNotify();
            }
        }
        public bool Completed
        {
            get { return this.completed; }
            set
            {
                this.completed = value;
                this.PropNotify();
            }
        }
    }
}