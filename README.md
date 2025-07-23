# 🎮 DustVault

**DustVault** is a modern mobile and web application designed for gamers and collectors to **track, organize, and value their video game collection**—all in one unified experience.

---

## 🧭 About the Project

Managing a growing game collection can be chaotic—between physical cartridges, digital licenses, price fluctuations, and wishlists, there's no centralized way to see it all.

**DustVault** solves this by offering:
- 🔍 **Smart search** powered by the IGDB API
- 💰 **Live market pricing** via PriceCharting integration
- 🎮 **Collection tracking** with cover art, platforms, and completion status
- 📱 A clean, responsive UI built with **React Native + Expo**
- ☁️ **Cross-platform sync** through Supabase (PostgreSQL backend)

---

## 🎯 Goal of the App

The goal of DustVault is to help gamers:

- 🗂 **Catalog their entire game library** (retro and modern)
- 📊 **Track game values** and price history in real-time
- 🎯 **Set goals**: what to play, what to finish, what to sell
- 🧾 **Export and back up** collection data
- 🔒 Maintain **secure, private access** to their data

Whether you're a hardcore collector or just nostalgic about your childhood games, **DustVault** aims to be your personal game vault.

---

## 🚀 Tech Stack

- **Frontend**: React Native (Expo)
- **API Layer**: ASP.NET Core Web API (.NET 9) - Middleware between frontend and external services
- **Backend**: Supabase (PostgreSQL + Auth + Storage)
- **External APIs**: IGDB (game data), PriceCharting (market prices)
- **Auth**: Email/password + future support for OAuth
- **Deployment Targets**: iOS, Android, Web (PWA), and later: Steam

---

## 🛠 Current Features (v1)

- [ ] Authentication: Login / Register / Forgot Password
- [ ] Home screen with featured games & stats
- [ ] My Collection: browse, filter, and search your games
- [ ] Game details page (platforms, region, price trends)
- [ ] Add/remove games from your library
- [ ] Wishlist support

---

## 🧪 Development Setup

1. Clone the repo:
   ```bash
   git clone https://github.com/your-user/dustvault.git
   cd dustvault
   ```

2. **Backend API Setup** (DustVault.Api):
   ```bash
   cd DustVault.Api
   dotnet restore
   dotnet run
   ```
   > The API will run on https://localhost:7034 with Swagger UI available

3. **Frontend Setup** (DustVault.Front):
   ```bash
   cd DustVault.Front
   npm install
   npx expo start
   ```

> **Requirements**: 
> - .NET 9 SDK for the API
> - Node.js 18+ and Expo CLI for the frontend

---

## 💡 Roadmap

* 🔐 Biometric login
* 🎮 Manual game entry for rare/unlisted titles
* 🏷️ Tagging, sorting, and completion status
* 📈 Price history charts
* 🛒 Integration with eBay and local marketplaces

---

## 🤝 Contributing

PRs are welcome! If you'd like to contribute:

* Open a new issue or pick one from the roadmap
* Fork the project and open a pull request
* Discuss major changes in the [Issues](https://github.com/your-user/dustvault/issues) tab

---

## 📫 Contact

Created by **[Benoit Ardiet](https://www.linkedin.com/in/benoitardiet/)**
DMs are open if you'd like to collaborate or share feedback!

---

## 📜 License

[MIT](LICENSE)

```

---

Let me know if you want to localize it (e.g. French/Spanish), or make it investor-oriented instead of developer-focused.
```