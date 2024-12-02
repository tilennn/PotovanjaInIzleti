using System;

public class Zasedenost : ZasedenostHotel , ZasedenostLetalo  {
	public void NastaviStatus(ref string status) {
		throw new System.NotImplementedException("Not implemented");
	}
	public string PridobiPodatke() {
		throw new System.NotImplementedException("Not implemented");
	}
	private string Status(ref LetalskiLet let, ref Datum datum) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Rezervacija rezervacija;

	private PodatkiZasedenost podatkiZasedenost;
	private LetalskaKarta letalskaKarta;
	private Hotel hotel;

}
