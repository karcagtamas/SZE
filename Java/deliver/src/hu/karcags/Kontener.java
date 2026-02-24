package hu.karcags;

import hu.karcags.csomagok.Kuldemeny;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Kontener {
    private final Integer maxSuly;
    private final List<Kuldemeny> csomagok;

    public Kontener(Integer maxSuly) {
        this.maxSuly = maxSuly;
        this.csomagok = new ArrayList<>();
    }

    public void hozzaad(Kuldemeny k) {
        if (this.maxSuly == -1 || this.maxSuly * 1000 > (jelenlegiSuly() + k.getSulyInGramm())) {
            if (!csomagok.contains(k)) {
                this.csomagok.add(k);
            }
        } else {
            throw new IllegalArgumentException("A csomag mar nem fer el a kontenerben");
        }
    }

    public boolean torol(Kuldemeny k) {
        return csomagok.remove(k);
    }

    public List<Kuldemeny> getCsomagok() {
        return Collections.unmodifiableList(this.csomagok);
    }

    public Integer getMaxSuly() {
        return maxSuly;
    }

    private Integer jelenlegiSuly() {
        return csomagok.stream()
                .map(Kuldemeny::getSulyInGramm)
                .reduce(0, Integer::sum);
    }
}
