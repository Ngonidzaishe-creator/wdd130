```css
/* WDD 130 Home Page
   Author: Ngonidzaishe Godfrey Chareka
*/

* {
    box-sizing: border-box;
}

body {
    margin: 0;
    font-family: Arial, Helvetica, sans-serif;
    line-height: 1.6;
    background-color: #f4f7f9;
    color: #222;
}

/* Header and Navigation */

header {
    background-color: #12355b;
    padding: 20px 0;
    border-bottom: 5px solid #f4b942;
}

nav {
    max-width: 900px;
    margin: 0 auto;
    display: flex;
    justify-content: center;
    gap: 30px;
}

nav a {
    color: white;
    text-decoration: none;
    font-size: 1.1rem;
    font-weight: bold;
    padding: 10px 20px;
    border-radius: 6px;
    transition: 0.3s ease;
}

nav a:hover {
    background-color: #f4b942;
    color: #12355b;
}

/* Main Content */

main {
    max-width: 900px;
    margin: 40px auto;
    padding: 35px;
    background-color: white;
    border-radius: 12px;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
}

h1 {
    color: #12355b;
    text-align: center;
    font-size: 2rem;
    margin-top: 0;
    margin-bottom: 30px;
    border-bottom: 3px solid #f4b942;
    padding-bottom: 15px;
}

/* Profile Image */

main img {
    display: block;
    width: 200px;
    height: 200px;
    object-fit: cover;
    margin: 0 auto 30px;
    border-radius: 50%;
    border: 6px solid #f4b942;
    box-shadow: 0 4px 12px rgba(0, 0, 0, 0.2);
}

/* Paragraphs */

main p {
    font-size: 1rem;
    margin-bottom: 20px;
    text-align: left;
}

/* Footer */

footer {
    background-color: #12355b;
    color: white;
    text-align: center;
    padding: 20px;
    margin-top: 40px;
}

footer p {
    margin: 0;
    font-size: 0.95rem;
}

/* Responsive Design */

@media screen and (max-width: 600px) {
    nav {
        flex-direction: column;
        align-items: center;
        gap: 5px;
    }

    nav a {
        width: 80%;
        text-align: center;
    }

    main {
        margin: 20px 10px;
        padding: 25px 20px;
    }

    h1 {
        font-size: 1.5rem;
    }

    main img {
        width: 160px;
        height: 160px;
    }
}
```
