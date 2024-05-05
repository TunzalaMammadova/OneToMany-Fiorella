using System;
using OneToMany_task.Models;

namespace OneToMany_task.ViewModels
{
	public class HomeVM
	{
		public List<Slider> Sliders{ get; set; }
		public SliderInfo SliderInfo { get; set; }
	}
}

