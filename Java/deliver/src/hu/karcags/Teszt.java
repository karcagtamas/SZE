package hu.karcags;

import hu.karcags.csomagok.KisCsomag;
import hu.karcags.csomagok.Kuldemeny;
import hu.karcags.csomagok.NagyCsomag;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.PrintStream;

import static java.util.stream.Collectors.joining;

public class Teszt {

    public static void main(String[] args) {
        setOutStream("vallaltneve.txt");

        // 1 vallalat
        final var vallalat = new CsomagkuldoVallalat("ABC Nagy vallalat");

        // 4-5 fuvar
        addFuvar(vallalat, "Pista", 500);
        addFuvar(vallalat, "Janos", 1000);
        addFuvar(vallalat, "Toni", -1);
        addFuvar(vallalat, "Karoly", 10000);
        addFuvar(vallalat, "Alma", 200);

        System.out.println(vallalat);

        System.out.print(vallalat.keres("1232 NagyVaros KisUtca 123/A")
                .stream()
                .map(Kuldemeny::toString)
                .collect(joining("\n")));
    }

    public static void addFuvar(CsomagkuldoVallalat vallalat, String nev, Integer max) {
        final var fuvar = new Fuvar(nev, max);

        // 3-4 csomag
        addCsomag(fuvar, true);
        addCsomag(fuvar, false);
        addCsomag(fuvar, true);
        addCsomag(fuvar, true);

        vallalat.hozzaad(fuvar);
    }

    public static void addCsomag(Fuvar fuvar, boolean kis) {
        final var tartalom = "Csomag tartalom";
        final var felado = "Kiss Reka";
        final var kCim = "1232 NagyVaros KisUtca 123/A";
        final Integer suly = (int) (1000 * Math.random() + 1);
        final var cim = "Cim";
        Kuldemeny k;

        if (kis) {
            k = new KisCsomag(tartalom, felado, kCim, suly, cim);
        } else {
            k = new NagyCsomag(tartalom, felado, kCim, suly, cim);
        }

        fuvar.hozzaad(k);
    }

    public static void setOutStream(String fileName) {
        try {
            final var file = new FileOutputStream(fileName, false);
            final var outStream = new PrintStream(file);

            System.setOut(outStream);
        } catch (FileNotFoundException e) {
            System.err.println("File not found with name: " + fileName);
        }
    }
}
