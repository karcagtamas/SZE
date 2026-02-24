package hu.karcags.csomagok;

import hu.karcags.common.StringBuilder;

public class NagyCsomag extends Kuldemeny {
    private String cim;

    public NagyCsomag(String tartalom, String felado, String kezbesitesiCim, Integer suly, String cim) {
        super(tartalom, felado, kezbesitesiCim, suly);
        this.cim = cim;
    }

    public String getCim() {
        return cim;
    }

    public void setCim(String cim) {
        this.cim = cim;
    }

    @Override
    public Integer getSulyInGramm() {
        return this.getSuly() * 1000;
    }

    @Override
    public String toString() {
        return new StringBuilder()
                .add("cim", this.cim)
                .add("tartalom", this.getTartalom())
                .add("felado", this.getFelado())
                .add("kezbesitesiCim", this.getKezbesitesiCim())
                .add("suly", this.getSuly().toString())
                .toString();
    }
}
