namespace Collections.Models
{
    class DictionaryExample
    {
        public static void Run()
        {
            Dictionary<string, string> states = [];

            states.Add("SP", "Sao Paulo");
            states.Add("BA", "Bahia");
            states.Add("PE", "Pernambuco");
            states.Add("RJ", "Rio de Janeiro");

            foreach (var state in states) {
                Console.WriteLine($"Key: {state.Key}, Value: {state.Value}");
            }

            try {
                states.Add("SP", "São Paulo");
            } catch (Exception e) {
                Console.WriteLine($"Exception occured: {e.Message}");
            }

            states.Remove("RJ");
            states["SP"] = "São Paulo";

            foreach (var state in states) {
                Console.WriteLine($"Key: {state.Key}, Value: {state.Value}");
            }

            string key = "RJ";

            if (states.ContainsKey(key)) {
                Console.WriteLine($"Existent key: {key}");
            } else {
                Console.WriteLine($"Key does not exist, its safe to add {key}");
            }
        }
    }
}