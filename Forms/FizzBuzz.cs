using System.ComponentModel.DataAnnotations;


namespace FizzBuzzWeb.Forms
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required(ErrorMessage = "Pole jest obowiązkowe"), Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        public int? Number { set; get; }

        public string CheckNumber(int? number)
        {
            string message = "";
            if(number >= 1 && number <= 1000)
            {
                if (number % 3 == 0)
                {
                    message += "Fizz";
                }
                if (number % 5 == 0)
                {
                    message += "Buzz";
                }

                if (message == "")
                {
                    message = "Liczba: " + number + " nie spełnia kryteriów FizzBuzz";
                }
            }

            return message;
        }

    }


    
}
