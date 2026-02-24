package hu.karcags;

import java.io.File;
import java.io.FileFilter;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) {
        File folder = new File(".");

        File[] files = folder.listFiles(File::isFile);

        assert files != null;
        Arrays.stream(files).forEach(f -> System.out.println(f.getName()));
    }
}
