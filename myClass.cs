namespace GitExercise
{
    class myClass
    {
        public string Navn {get; set;}
        public string Adresse {get; set;}
        public int Postnr {get; set;}
        public string By {get; set;}

        public myClass (string navn, string adresse, int postnr, string by)
        {
            Navn = navn;
            Adresse = adresse;
            Postnr = postnr;
            By = by;
        }
        public override string ToString()
        {
            return $"Person hedder {Navn}, personen bor {Adresse} i postnr {Postnr} og bor i byen {By}";
        }
        
    }
}