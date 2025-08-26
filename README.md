# 🌈 Rainbow Hop Challenge – A ZetaChain GameFi Experience  

Play now 👉 [Rainbow Hop Challenge on Itch.io](https://thkien85.itch.io/rainbow-hop-challenge-on-zetachain)  
Source 👉 [GitHub Repository](https://github.com/KelvinTrinhSG/Rainbow-Hop-Challenge-On-ZetaChain)  

---

## 🔥 Overview  
Rainbow Hop Challenge is a blockchain-integrated GameFi experience built on the **ZetaChain Athens Testnet**. Players bounce their ball upward, match blocks of the same color, collect gems, and earn on-chain rewards. With NFTs and GEM tokens, your gameplay achievements translate into real blockchain value.  

---

## 🎮 Gameplay Features  
- 🏐 **Bounce Upwards** – Tap to bounce the ball higher.  
- 🎨 **Color Match** – Pass through blocks that match your color or lose the round.  
- 💎 **Gem Collection** – Gather gems as you rise to unlock new rewards.  
- 🔁 **Spin to Earn** – Burn GEM tokens to spin the Fortune Wheel for bonuses or doubled scores.  
- 🎟️ **Token Gate Access** – Requires a Token Gate NFT to play.  
- 👑 **VIP Boosts** – VIP NFT holders enjoy score multipliers and faster progression.  
- 💰 **Real Rewards** – Redeem your in-game points for **ZETA** (via off-chain claim form).  

---

## 🧱 Built On  
- 🔗 **ZetaChain Athens Testnet** – Universal L1 enabling cross-chain GameFi with low fees and fast confirmations.  
- 🛠 **thirdweb SDK** – For NFT drops, token contracts, and blockchain integration.  
- 🎮 **Unity Engine** – Smooth gameplay and colorful mechanics.  

---

## 📦 Smart Contracts (ZetaChain)  
- 🧩 **Token Gate NFT**  
  - **Symbol:** GATE  
  - Grants access to play the game. (Free claim)  

- 👑 **VIP NFT**  
  - **Symbol:** VIP  
  - Costs ZETA.  
  - Grants score multipliers and VIP-only features.  

- 💠 **GEM Token (ERC20)**  
  - **Symbol:** GEM  
  - Used for spinning the Fortune Wheel.  
  - Claimable for a small amount of ZETA.  

*(All deployed via Thirdweb – contract addresses available in developer’s dashboard.)*  

---

## 🪙 Exchange Points for ZETA  
Players can submit their **TotalScore** for ZETA rewards via the official off-chain claim form. This allows your in-game achievements to directly translate into real crypto value.  

---

## 🌱 Future Goals  
- Implement fully on-chain ZETA redemption.  
- Add global leaderboard with competitive rewards.  
- Expand color mechanics (moving blocks, power-ups).  
- Release mobile version (Android/iOS).  

---

## 🙌 Credits  
Built with ❤️ by **KelvinTrinhSG** using Thirdweb + ZetaChain.  

---

## 🛠️ How to Clone and Continue Development  

### 🔄 Clone the Repository  
```bash
git clone https://github.com/KelvinTrinhSG/Rainbow-Hop-Challenge-On-ZetaChain.git
```  

### 💻 Open in Unity  
- Launch **Unity Hub**  
- Select **Add Project** → choose the cloned folder  
- Use **Unity version 2022.3+ (LTS recommended)**  

### ⚙️ Set Up Thirdweb SDK  
- Download and install **Thirdweb Unity SDK**  
- Configure wallet + set up contracts:  
  - Token Gate NFT  
  - VIP NFT  
  - GEM Token  

### 🧪 Play & Modify  
- Open `Scenes/MainGame.unity`  
- Adjust scripts in `Scripts/` or UI under `Canvas/`  
- Add new features, skins, or power-ups  

### 🚀 Build & Deploy  
- Build in **WebGL**  
- Deploy to **Itch.io** or ZetaChain-supported hosting  
- Ensure ZetaChain wallet integration works for Web3 features  

---

## 🌍 Extended Overview – Universal NFT on ZetaChain  

The project also integrates **Universal NFT technology** using two ERC-721 contracts:  

1. **Universal NFT on ZetaChain**  
   - Must be deployed on ZetaChain.  
   - Handles minting NFTs directly on ZetaChain.  
   - Enables transferring NFTs to connected chains.  
   - Ensures tokens can move seamlessly between ZetaChain and external EVM chains.  

2. **Universal NFT on EVM Chains**  
   - Deployed on connected EVM networks (e.g., BSC, Polygon).  
   - Receives messages from ZetaChain when a cross-chain transfer occurs.  
   - Mints the mirrored NFT after burning on the source chain.  

**Cross-Chain Mechanism:**  
- When transferring a token between chains:  
  - The token is **burned** on the source chain.  
  - Metadata + token information are packaged into a message.  
  - A corresponding token is then **minted** on the destination chain’s Universal NFT contract.  

---

## 🎮 Cross-Game Play with Universal NFTs  

Thanks to this feature, players can now use their NFTs across multiple connected GameFi experiences, not just within Rainbow Hop Challenge.  

- 🌆 **[Skyline Builder on BSC](https://thkien85.itch.io/skyline-builder-on-bsc)**  
  Transfer your Rainbow Hop Challenge NFT to the **BSC** chain and unlock gameplay in *Skyline Builder*.  

- 🌲 **[Forest Guardians on Polygon](https://thkien85.itch.io/forest-guardians-on-polygon)**  
  Move your NFT to the **Polygon** chain and defend the forest in *Forest Guardians*.  

This means your NFT identity and progress become **universal across games**, powered by ZetaChain’s cross-chain architecture.  
