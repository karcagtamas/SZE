package hu.karcags;

public class Etel implements Kiszallithato {

    private String nev;
    private int ar;

    public Etel(String nev, int ar) {
        this.nev = nev;
        setAr(ar);
    }

    @Override
    public boolean isKiszallithato() {
        return ar > 500;
    }

    @Override
    public int getAr() {
        return 0;
    }

    public void setAr(int ar) {
        this.ar = ar;
    }

    @Override
    public String getNev() {
        return null;
    }

    public void setNev(String nev) {
        this.nev = nev;
    }

    @Override
    public String toString() {
        return "Etel{" +
                "nev='" + nev + '\'' +
                ", ar=" + ar +
                ", kiszallithato=" + (isKiszallithato() ? "igen" : "nem") +
                '}';
    }
}
