package hu.karcags;

import hu.karcags.csomagok.Kuldemeny;

import java.util.stream.Stream;

import static java.util.stream.Collectors.joining;

public class Fuvar {
    private String szallito;
    private final Kontener kontener;

    public Fuvar(String szallito) {
        this(szallito, -1);
    }

    public Fuvar(String szallito, Integer max) {
        this.szallito = szallito;
        this.kontener = new Kontener(max >= 0 ? max : -1);
    }

    public String getSzallito() {
        return szallito;
    }

    public void setSzallito(String szallito) {
        this.szallito = szallito;
    }

    public void hozzaad(Kuldemeny k) {
        try {
            this.kontener.hozzaad(k);
        } catch (IllegalArgumentException e) {
            System.err.println(e.getMessage());
        }
    }

    public boolean torol(Kuldemeny k) {
        return this.kontener.torol(k);
    }

    public Stream<Kuldemeny> keres(String cimzett) {
        return this.kontener.getCsomagok().stream()
                .filter(x -> x.getKezbesitesiCim().equals(cimzett));
    }

    @Override
    public String toString() {
        return kontener
                .getCsomagok()
                .stream()
                .map(Kuldemeny::toString)
                .collect(joining("\n"));
    }
}
