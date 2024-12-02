using System;

public class EntitetaPaketov {
	public Paket PridobiPodrobnosti(ref int idPaketa) {
		throw new System.NotImplementedException("Not implemented");
	}
	public bool PreveriRazpoložljivost() {
		throw new System.NotImplementedException("Not implemented");
	}
	public bool PreveriRazpoložljivost(ref LetalskiLet let, ref Datum datum) {
		throw new System.NotImplementedException("Not implemented");
	}

	private KontrolaPaketov kontrolaPaketov;

	private Rezervacija[] rezervacijas;
	private IzbiraPaketaOkno izbiraPaketaOkno;
	private Rezervacija rezervacija;
	private UpravljanjeRezervacije upravljanjeRezervacije;

}
