﻿namespace campany.web.Controllers
{
	public class SignUpViewModel
	{
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }

		public bool IsAgree { get; set; }
	}
}
