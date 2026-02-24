package hu.karcags;

import hu.karcags.csomagok.Kuldemeny;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

import static java.util.stream.Collectors.toList;

public class CsomagkuldoVallalat {
    private String nev;
    private final List<Fuvar> fuvarok = new ArrayList<>();

    public CsomagkuldoVallalat(String nev) {
        this.nev = nev;
    }

    public String getNev() {
        return nev;
    }

    public void setNev(String nev) {
        this.nev = nev;
    }

    public void hozzaad(Fuvar f) {
        if (Objects.isNull(f)) {
            return;
        }

        fuvarok.add(f);
    }

    public List<Kuldemeny> keres(String cimzett) {
        return this.fuvarok.stream()
                .flatMap(x -> x.keres(cimzett))
                .collect(toList());
    }

    @Override
    public String toString() {
        return fuvarok.isEmpty()
                ? "Nincs kontener"
                : String.format("Van kontener. Jelenleg %s kontener szallit", fuvarok.size());
    }
}
