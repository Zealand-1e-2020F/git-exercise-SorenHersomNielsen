namespace GitExercise
{
    class myClass
    {
        public string Navn {get; set;}
        public string Adresse {get; set;}
        public int Postnr {get; set;}

        public myClass (string navn, string adresse, int postnr)
        {
            Navn = navn;
            Adresse = adresse;
            Postnr = postnr;
        }
    }
}