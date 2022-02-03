Designating an HTML file for the structure of the page, a CSS file for the styling, and JavaScript file for interaction or events is called separation of concerns (serpação de preocupações).

# Content = HTML
## HTML file - content and page structure
    HTML elements - meta (metadata) and character set (charset/conjunto de caracteres)
        Metadata - defines data about the HTML document, such as character set, scripts, and whihch browser the webpage opens in.
    <p> é utilizado para estilizar um elemento
    class (usado no elemento <li>) é para estilizar todos os elementos da mesma classe.


# Style = CSS
## CSS file - presentation and styling 
    - Internal CSS - Writing the CSS code directly in the head of the webpage.
        Even for a basic website, there are so many CSS rules the HTML page can become cluttered (desordenada) very quickly.
        With more than one page, the same CSS would often be repeated and challenging to manage.

    - External CSS - Having a separate page.
        You use one or more external style sheets to service multiple webpages. Rather than updating each HTML page with replicated CSS code, you can make changes to a single CSS file, and have those updates applied to all the dependent web pages.

    - What you're selecting is an existing element that you previously defined in HTML (<body> and <ul>).

    - The unordered list element ul {} is a selector, with selects the <ul> HTML element to apply styles. The declaration is font-family: helvetica and determines what the style should be. The property name is font-family, and the value is helvetica. The property and value together make a key-value pair.

    - ID and class selectors enable you to apply styles to custom attribute names in your HTML. An ID is used to style one element, whereas classes can style multiple elements. The proceding custom attributes are called .list (class selector) and #msg(ID):

        "list" - Each HTML element that contains a class atribute set to "list" will inherit the styles that are defined within this selector.
        
        #msg - The HTML element that has its id attribute set to "msg" will inherit the styles that are defined within this selector.



# Business Logic = JavaScript files
## JavaScript file - behaviors and interactivity

- By Styling elements in HTML using CSS, you can simplify the formatting for the pages by applying CSS styles to all the elements on a page, regardless of the page complexity, rather than coding the appearance within each HTML elements. In addition, you can link multiple HTML pages to a single CSS file, which can help simplify a conssitente look and feel across the entire website.

- Setting up three files helps keep the website project organiized. The separation of content, styles and logic is an example of progressive enhancement (avanço progressivo). If JavaScript isn't enabled or supported by the customers, the CSS and HTML will still work. However, if CSS isn't supported by the customers, at least your HTML content will appear.

