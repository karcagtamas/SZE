package hu.karcags.common;

public class StringBuilder {
    final java.lang.StringBuilder builder = new java.lang.StringBuilder();

    public StringBuilder add(String name, String value) {
        this.builder.append(String.format("%s: %s,", name, value));
        return this;
    }

    @Override
    public String toString() {
        return this.builder.toString();
    }
}
