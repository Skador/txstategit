/**
 * Created by Skador on 3/6/2017.
 */
public class TextBook {
  private String title, author, publisher;

  public TextBook(String textTitle, String auth, String pub) {
    title = textTitle;
    author = auth;
    publisher = pub;
  }

  public TextBook(TextBook object2) {
    title = object2.title;
    author = object2.author;
    publisher = object2.publisher;
  }

  public void set(String textTitle, String auth, String pub) {
    title = textTitle;
    author = auth;
    publisher = pub;
  }

  public String toString(){
    String str = " Title: " + title +
        "\n Author: " + author +
        "\n Publisher: " + publisher;
    return str;
  }
}
