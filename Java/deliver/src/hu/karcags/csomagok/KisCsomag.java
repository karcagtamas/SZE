package hu.karcags.csomagok;

import hu.karcags.common.StringBuilder;

public class KisCsomag extends Kuldemeny {
    private String cim;

    public KisCsomag(String tartalom, String felado, String kezbesitesiCim, Integer suly, String cim) {
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
