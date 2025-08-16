# Muse Dash Merchandise Shop Simulator 🛍️

<p align="center">
  <img src="Muse%20Dash%20Merchandise/screenshots/MainMenu.gif" alt="Main Menu Animation" width="600"/>
</p>

This project is a simple point-of-sale (POS) simulator inspired by the vibrant art style of the rhythm game **Muse Dash**. It was created as a hands-on activity for a **Computer Programming 2** course to practice building a multi-form application, managing application state, and handling user interface events in VB.NET.

The simulator allows users to browse and purchase official merchandise from the **Muse Dash peropero store**, with a special guest cashier appearance from the **Touhou Project**.

---

## Core Features 🛒

-   **Browse Merchandise**: Users can navigate through different items in two separate shops using next and previous buttons.
-   **Two Separate Shops**: The application features a Badge Shop and a Keychain Shop, each with its own set of items based on official Muse Dash merchandise.
-   **Add to Cart**: A simple "Purchase/Buy" button allows users to add items to their virtual shopping cart, which updates the total cost in real-time.
-   **Dynamic Checkout Process**: A checkout screen summarizes the purchased items and their quantities, calculates the grand total, and prompts for payment.
-   **Payment Simulation**: The system accepts a payment amount, calculates the correct change, and provides feedback to the user).

## Technical Implementation 👨‍💻

-   **Language**: VB.NET (Windows Forms)
-   **Architecture**: The application is built using a multi-form structure to separate different views (Main Menu, Badge Shop, Keychain Shop, Checkout, etc.).
-   **State Management**: Data such as the total cost and individual item counts are passed between forms using public variables. This is a common method for managing state in smaller Windows Forms applications.
-   **Event-Driven UI**: All user interactions are managed through event handlers (e.g., `Button_Click`), which update the UI by dynamically changing `PictureBox` images and `Label` text content to create an interactive shopping experience.

## Project Showcase 🖼️

Here is a quick walkthrough of the shopping experience.

#### The Badge Shop
Browse through a selection of character badges.
![Badge Shop Showcase](Muse%20Dash%20Merchandise/screenshots/BadgeShop.gif)

#### The Keychain Shop
Check out the available keychains.
![Keychain Shop Showcase](Muse%20Dash%20Merchandise/screenshots/KeychainShop.png)

#### Checkout & Payment
Review your items, enter a payment amount, and get your change.
![Checkout Process](Muse%20Dash%20Merchandise/screenshots/CheckOut.gif)

---

## Copyright & Disclaimer ©️

**Important: Educational Project / Fair Use**

This project is a non-commercial, educational fan-work created solely for a school activity. Its purpose is to demonstrate programming skills learned in the Computer Programming 2 course.

All character art, merchandise designs, and other visual assets are the intellectual property of their respective copyright holders.

-   **Muse Dash Merchandise & Assets**: All merchandise designs (badges, keychains) and related game assets are copyright of **PeroPeroGames**.
-   **Touhou Project Character**: The sprite for the cashier, Reimu Hakurei, is from the Touhou Project, which is copyright of **Team Shanghai Alice (ZUN)**.

This project is not affiliated with or endorsed by either PeroPeroGames or Team Shanghai Alice. No copyright infringement is intended.
