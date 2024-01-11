namespace ElementaCibi.Data.FdcModels
{
    //The id and number codes for the FDC nutrients. These were determined from the response objects when hitting the FDC api.
    public static class NutrientCode
    {
        public static class Calorie
        {
            public const int Id = 1008;
            public const int Number = 208;
        }

        public static class Fiber
        {
            public const int Id = 1079;
            public const int Number = 291;
        }
    }
}
