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

- JavaScript (or ECMAScript) is a programming language that helps you interactivity add to your web pages. For example, you can use JavaScript to define the event or behavior that will happen when a user selects a button; for example, open a pop-up window. Using JavaScript, you can add or remove content from a web page without reloading it.

- Like CSS, you could add JavaScript directly to the HTML file, but a recommended best practice is to save your JavaScript in a separate file, which makes it easier to reuse your JvaScript codee across several web pages.

- The <script> element could be placed in the <head> or elsewhere in the <body>. However, putting <script> element at the end of the <body> section enables all the page content to display on the screen first, and then load the script.

- Adding a <noscript> element after closing </script> tag, wich can be used to show a message if JavaScript is deactivated(desativado).
    Adding a <noscript> element is an example of fault tolerance(tolerância a falhas) or graceful degradation(degradação normal). By using the <noscript> element, your code can detect and plan for when a feature isn't supported or available.

- As you get started with JavaScript, your inicial focus is often going to be working with numbers, math, text manipulation, dates, and storing information. Sometimes JavaScript makes assumptions about the type of data you enter; for example, assignment, math, or logical equality can give you unexpected results. JavaScript tries to be friendly, make your code work, and provide you with a solution, even if the result should be an error. To override this behavior, you can activate 'strict mode', which reduces silent erros, improves performance and provides you with more warnings and fewer unsafe features.

- Remember of adding semicolon (;) at the end of the line of code. It's possible to omit a closing semicolon from JavaScript code becauce of ASI (Automatic Semicolon Insertion). But sometimes it fails. So you should consider using semicolons as a best practice.

- It's a JavaScript convention to use camel case (Caixa de Camelo) for variable names with more than one word; for example: the variable className.

- You can create a hidden message that won't appear on yout webpage. However, what you write in the console will show up in the browser developer tools. Using console messaages can be really helpful for seeing the result of your code.

