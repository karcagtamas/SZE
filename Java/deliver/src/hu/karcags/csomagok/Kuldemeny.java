package hu.karcags.csomagok;

import hu.karcags.common.StringBuilder;
import hu.karcags.interfaces.Kiszallithato;

public abstract class Kuldemeny implements Kiszallithato {
    private String tartalom;
    private String felado;
    private String kezbesitesiCim;
    private Integer suly;

    public Kuldemeny(String tartalom, String felado, String kezbesitesiCim, Integer suly) {
        this.tartalom = tartalom;
        this.felado = felado;
        this.kezbesitesiCim = kezbesitesiCim;
        this.suly = suly;
    }

    @Override
    public String getTartalom() {
        return tartalom;
    }

    @Override
    public void setTartalom(String tartalom) {
        this.tartalom = tartalom;
    }

    @Override
    public String getFelado() {
        return felado;
    }

    @Override
    public void setFelado(String felado) {
        this.felado = felado;
    }

    @Override
    public String getKezbesitesiCim() {
        return kezbesitesiCim;
    }

    @Override
    public void setKezbesitesiCim(String kezbesitesiCim) {
        this.kezbesitesiCim = kezbesitesiCim;
    }

    @Override
    public Integer getSuly() {
        return suly;
    }

    public Integer getSulyInGramm() {
        return this.suly;
    }

    @Override
    public void setSuly(Integer suly) {
        this.suly = suly;
    }

    @Override
    public String toString() {
        return new StringBuilder()
                .add("tartalom", this.tartalom)
                .add("felado", this.felado)
                .add("kezbesitesiCim", this.kezbesitesiCim)
                .add("suly", this.suly.toString())
                .toString();
    }
}
