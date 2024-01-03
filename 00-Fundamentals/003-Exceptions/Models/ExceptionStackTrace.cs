namespace Classes.Models {
    public class ExceptionStackTrace {
        public static void Method1() {
            try {
                Method2();
            } catch (Exception e) {
                Console.WriteLine("Exception handled: " + e.Message);
            }
        }

        public static void Method2() {
            Method3();
        }

        public static void Method3() {
            Method4();
        }

        public static void Method4() {
            throw new Exception("An exception occured");
        }
    }
}