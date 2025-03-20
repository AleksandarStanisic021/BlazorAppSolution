using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class MessageModel
	{
		[Required]
		public string? Message { get; set; }
	
	}
}
