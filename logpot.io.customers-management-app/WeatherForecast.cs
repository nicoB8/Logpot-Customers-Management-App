namespace logpot.io.customers_management_app
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public void BubbleSort(int[] arr)
        {
            bool swapped;
            int temp;
            var arrLength = arr.Length;
            for (var i = 0; i < arrLength - 1; i++)
            {
                swapped = false;
                for (var j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j]  = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}