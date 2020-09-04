using System;
using System.Collections.ObjectModel;

public class MainPageViewModel
{
	public MainPageViewModel()
	{
		for(int i =0; i<100; i++)
        {
			var item = new Models.TodoItem()
			{
				Title = string.Format("Task title {0}", i)
			};
			this.Items.add(item);
        }
	}
	public ObservableCollection<Models.TodoItem> Items
    {
		get;private set;
    } = new ObservableCollection<Models.TodoItem>();
}
