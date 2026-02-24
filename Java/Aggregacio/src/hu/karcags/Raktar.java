package hu.karcags;

public class Raktar {
    private String nev;
    private Termek[] termekek;
    private int termekDarab;

    public Raktar(String nev) {
        this(nev, 10);
    }

    public Raktar(String nev, int meret) {
        this.nev = nev;
        termekek = new Termek[meret];
        termekDarab = 0;
    }

    public String getNev() {
        return nev;
    }

    public void setNev(String nev) {
        this.nev = nev;
    }

    public void addTermek(Termek termek) {
        if (termekDarab >= termekek.length) {
            return;
        }

        termekek[termekDarab] = termek;
        termekDarab++;
    }
}
