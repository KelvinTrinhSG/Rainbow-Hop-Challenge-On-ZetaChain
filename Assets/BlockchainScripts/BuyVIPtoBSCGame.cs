using UnityEngine;
using TMPro;
using Thirdweb;
using UnityEngine.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using UnityEngine.Networking;

public class BuyVIPtoBSCGame : MonoBehaviour
{
    public TMP_Text warningText;
    public Button vipBSCButton;
    public Button backButton;
    public Button vipBSCGameButton;
    public Button vipBASEButton;
    public Button vipBASEGameButton;
    public string Address { get; private set; }
    private string abi = "[{\"inputs\":[],\"name\":\"AdditionsOverflow\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"target\",\"type\":\"address\"}],\"name\":\"AddressEmptyCode\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"ApproveFailed\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"CantBeIdenticalAddresses\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"CantBeZeroAddress\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"implementation\",\"type\":\"address\"}],\"name\":\"ERC1967InvalidImplementation\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"ERC1967NonPayable\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"ERC721EnumerableForbiddenBatchMint\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"}],\"name\":\"ERC721IncorrectOwner\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"operator\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"ERC721InsufficientApproval\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"approver\",\"type\":\"address\"}],\"name\":\"ERC721InvalidApprover\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"operator\",\"type\":\"address\"}],\"name\":\"ERC721InvalidOperator\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"}],\"name\":\"ERC721InvalidOwner\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"receiver\",\"type\":\"address\"}],\"name\":\"ERC721InvalidReceiver\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"}],\"name\":\"ERC721InvalidSender\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"ERC721NonexistentToken\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"index\",\"type\":\"uint256\"}],\"name\":\"ERC721OutOfBoundsIndex\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"FailedCall\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"IdenticalAddresses\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InsufficientInputAmount\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InsufficientLiquidity\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InvalidAddress\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InvalidGasLimit\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InvalidInitialization\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InvalidPath\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"InvalidPathLength\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"MultiplicationsOverflow\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"NotInitializing\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"}],\"name\":\"OwnableInvalidOwner\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"}],\"name\":\"OwnableUnauthorizedAccount\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"TransferFailed\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"UUPSUnauthorizedCallContext\",\"type\":\"error\"},{\"inputs\":[{\"internalType\":\"bytes32\",\"name\":\"slot\",\"type\":\"bytes32\"}],\"name\":\"UUPSUnsupportedProxiableUUID\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"Unauthorized\",\"type\":\"error\"},{\"inputs\":[],\"name\":\"ZeroAddress\",\"type\":\"error\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"approved\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"Approval\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"operator\",\"type\":\"address\"},{\"indexed\":false,\"internalType\":\"bool\",\"name\":\"approved\",\"type\":\"bool\"}],\"name\":\"ApprovalForAll\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"_fromTokenId\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"_toTokenId\",\"type\":\"uint256\"}],\"name\":\"BatchMetadataUpdate\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"uint64\",\"name\":\"version\",\"type\":\"uint64\"}],\"name\":\"Initialized\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"_tokenId\",\"type\":\"uint256\"}],\"name\":\"MetadataUpdate\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"previousOwner\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"newOwner\",\"type\":\"address\"}],\"name\":\"OwnershipTransferred\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"zrc20\",\"type\":\"address\"},{\"indexed\":false,\"internalType\":\"address\",\"name\":\"contractAddress\",\"type\":\"address\"}],\"name\":\"SetConnected\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"universalAddress\",\"type\":\"address\"}],\"name\":\"SetUniversal\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"string\",\"name\":\"uri\",\"type\":\"string\"}],\"name\":\"TokenMinted\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"destination\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"receiver\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"string\",\"name\":\"uri\",\"type\":\"string\"}],\"name\":\"TokenTransfer\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"receiver\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"string\",\"name\":\"uri\",\"type\":\"string\"}],\"name\":\"TokenTransferReceived\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"string\",\"name\":\"uri\",\"type\":\"string\"}],\"name\":\"TokenTransferReverted\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"destination\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"string\",\"name\":\"uri\",\"type\":\"string\"}],\"name\":\"TokenTransferToDestination\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"from\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"Transfer\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"implementation\",\"type\":\"address\"}],\"name\":\"Upgraded\",\"type\":\"event\"},{\"inputs\":[],\"name\":\"UPGRADE_INTERFACE_VERSION\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"approve\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"}],\"name\":\"balanceOf\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"burn\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"name\":\"connected\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"gasLimitAmount\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"gateway\",\"outputs\":[{\"internalType\":\"contractGatewayZEVM\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"getApproved\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"initialOwner\",\"type\":\"address\"},{\"internalType\":\"string\",\"name\":\"name\",\"type\":\"string\"},{\"internalType\":\"string\",\"name\":\"symbol\",\"type\":\"string\"},{\"internalType\":\"address payable\",\"name\":\"gatewayAddress\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"gas\",\"type\":\"uint256\"},{\"internalType\":\"address\",\"name\":\"uniswapRouterAddress\",\"type\":\"address\"}],\"name\":\"initialize\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"operator\",\"type\":\"address\"}],\"name\":\"isApprovedForAll\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"isUniversal\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"name\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"components\":[{\"internalType\":\"bytes\",\"name\":\"origin\",\"type\":\"bytes\"},{\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"chainID\",\"type\":\"uint256\"}],\"internalType\":\"structMessageContext\",\"name\":\"context\",\"type\":\"tuple\"},{\"internalType\":\"address\",\"name\":\"zrc20\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"amount\",\"type\":\"uint256\"},{\"internalType\":\"bytes\",\"name\":\"message\",\"type\":\"bytes\"}],\"name\":\"onCall\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"components\":[{\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"asset\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"amount\",\"type\":\"uint256\"},{\"internalType\":\"bytes\",\"name\":\"revertMessage\",\"type\":\"bytes\"}],\"internalType\":\"structRevertContext\",\"name\":\"context\",\"type\":\"tuple\"}],\"name\":\"onRevert\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"owner\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"ownerOf\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"proxiableUUID\",\"outputs\":[{\"internalType\":\"bytes32\",\"name\":\"\",\"type\":\"bytes32\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"renounceOwnership\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"internalType\":\"string\",\"name\":\"uri\",\"type\":\"string\"}],\"name\":\"safeMint\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"from\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"safeTransferFrom\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"from\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"internalType\":\"bytes\",\"name\":\"data\",\"type\":\"bytes\"}],\"name\":\"safeTransferFrom\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"operator\",\"type\":\"address\"},{\"internalType\":\"bool\",\"name\":\"approved\",\"type\":\"bool\"}],\"name\":\"setApprovalForAll\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"zrc20\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"contractAddress\",\"type\":\"address\"}],\"name\":\"setConnected\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes4\",\"name\":\"interfaceId\",\"type\":\"bytes4\"}],\"name\":\"supportsInterface\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"symbol\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"index\",\"type\":\"uint256\"}],\"name\":\"tokenByIndex\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"owner\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"index\",\"type\":\"uint256\"}],\"name\":\"tokenOfOwnerByIndex\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"tokenURI\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"totalSupply\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"},{\"internalType\":\"address\",\"name\":\"receiver\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"destination\",\"type\":\"address\"}],\"name\":\"transferCrossChain\",\"outputs\":[],\"stateMutability\":\"payable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"from\",\"type\":\"address\"},{\"internalType\":\"address\",\"name\":\"to\",\"type\":\"address\"},{\"internalType\":\"uint256\",\"name\":\"tokenId\",\"type\":\"uint256\"}],\"name\":\"transferFrom\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"newOwner\",\"type\":\"address\"}],\"name\":\"transferOwnership\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"uniswapRouter\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"newImplementation\",\"type\":\"address\"},{\"internalType\":\"bytes\",\"name\":\"data\",\"type\":\"bytes\"}],\"name\":\"upgradeToAndCall\",\"outputs\":[],\"stateMutability\":\"payable\",\"type\":\"function\"},{\"stateMutability\":\"payable\",\"type\":\"receive\"}]";
    private string smartContractAddressZETA = "0x24fF42a1241944da9C85877EBcaeBEc12d1561b8";
    private string uriNFT = "https://turquoise-acute-bird-570.mypinata.cloud/ipfs/bafkreigssmzrwra53zhkqmzvojzgqes4gzepszzqki7jdjzqv4fxwnjpvy";
    private string destinationBSC = "0xd97B1de3619ed2c6BEb3860147E30cA8A7dC9891";
    private string destinationPOLY = "0x777915D031d1e8144c90D025C594b3b8Bf07a08d";
    public bool CheckScore()
    {
        int totalScore = PlayerPrefs.GetInt("TotalScore", 0);

        if (totalScore >= 1000)
        {
            return true;
        }
        else
        {
            if (warningText != null)
            {
                warningText.text = "Your score must be at least 1000!";
            }
            return false;
        }
    }

    public bool CheckVIP()
    {
        if (PlayerDataManager.Instance.vipNFT >= 1)
        {
            return true;
        }
        else
        {
            if (warningText != null)
            {
                warningText.text = "You need at least 1 VIP NFT!";
            }
            return false;
        }
    }

    public bool CheckScore2000()
    {
        int totalScore = PlayerPrefs.GetInt("TotalScore", 0);

        if (totalScore >= 2000)
        {
            return true;
        }
        else
        {
            if (warningText != null)
            {
                warningText.text = "Your score must be at least 2000!";
            }
            return false;
        }
    }

    public void substractScore(int scoreValue)
    {
        // 1. Lấy điểm hiện tại
        int currentScore = PlayerPrefs.GetInt("TotalScore", 0);
        // 2. Trừ điểm
        int newScore = currentScore - scoreValue;
        // 3. Đảm bảo không âm (nếu muốn)
        if (newScore < 0)
            newScore = 0;
        // 4. Lưu lại
        PlayerPrefs.SetInt("TotalScore", newScore);
        PlayerPrefs.Save();
        // 5. Debug
        Debug.Log("TotalScore updated to: " + newScore);
        BalanceFetcher balanceFetcher = FindObjectOfType<BalanceFetcher>();
        if (balanceFetcher != null)
        {
            balanceFetcher.FetchAllBalances();
        }
        else
        {
            Debug.LogWarning("BalanceFetcher not found in the scene.");
        }
    }



    private void HideAllButtons() {
        vipBSCButton.interactable = false;
        backButton.interactable = false;
        vipBSCGameButton.interactable = false;
        vipBASEButton.interactable = false;
        vipBASEGameButton.interactable = false;
    }

    private void ShowAllButtons()
    {
        vipBSCButton.interactable = true;
        backButton.interactable = true;
        vipBSCGameButton.interactable = true;
        vipBASEButton.interactable = true;
        vipBASEGameButton.interactable = true;
    }

    private string ParseJson(string jsonStringGive)
    {
        JObject jsonObject = JObject.Parse(jsonStringGive);
        JToken receipt = jsonObject["receipt"];

        if (receipt != null)
        {
            JArray events = (JArray)receipt["events"];

            if (events != null)
            {
                foreach (JObject ev in events)
                {
                    if (ev["event"]?.ToString() == "Transfer")
                    {
                        JArray args = (JArray)ev["args"];
                        string value = args[2].ToString();

                        Debug.Log("Giá trị cần tìm: " + value);

                        return value;
                    }
                }
            }
            return null;
        }
        return null;
    }

    public async void BuyBSCGameVIPNFT()
    {
        if (!CheckScore()) return; // nếu chưa đủ điểm thì dừng
        if (!CheckVIP()) return;   // nếu chưa có VIP NFT thì dừng
        // Chỉ chạy khi cả 2 điều kiện đều thỏa
        Debug.Log("Action executed because requirements met!");
        Debug.Log("Buying NFT Pass to Skyline Builder On BSC chain");
        warningText.text = "Buying NFT Pass to Skyline Builder On BSC chain";
        HideAllButtons();
        Address = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();
        CallTransfer(Address, destinationBSC);

        try
        {
            var contract = ThirdwebManager.Instance.SDK.GetContract(
                smartContractAddressZETA,
                abi
            );
            // gọi hàm read
            string nftOwned = await contract.Read<string>("balanceOf", Address);
            // in ra console
            Debug.Log($"VIP NFT owned by {Address}: {nftOwned}");
            // xuất ra UI text (giả sử bạn có một Text hoặc TMP_Text tên balanceText)
            warningText.text = $"BSC VIP NFT owned: {nftOwned}";
            //// Gọi mint
            //var writeResult = await contract.Write("safeMint", Address, uriNFT);

            //string json = JsonConvert.SerializeObject(writeResult, Formatting.Indented);
            //string tokenID = ParseJson(json);

            //try
            //{
            //    // gọi hàm read
            //    string nftOwned = await contract.Read<string>("balanceOf", Address);

            //    // in ra console
            //    Debug.Log($"VIP NFT owned by {Address}: {nftOwned}");

            //    // xuất ra UI text (giả sử bạn có một Text hoặc TMP_Text tên balanceText)
            //    warningText.text = $"VIP NFT owned: {nftOwned}";

            //    CallTransfer(tokenID, Address, destinationBSC);
            //}
            //catch (Exception ex)
            //{
            //    Debug.LogError($"Error reading NFT balance: {ex}");
            //    warningText.text = $"Error: {ex.Message}";
            //}
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Error reading NFT balance: {ex}");
            warningText.text = $"Error: {ex.Message}";
        }
        finally
        {
            ShowAllButtons();
            warningText.text = "Please wait 3 minutes then you can play Skyline Builder On BSC chain";
        }
    }

    public async void BuyPOLYGameVIPNFT()
    {
        if (!CheckScore2000()) return; // nếu chưa đủ điểm thì dừng
        if (!CheckVIP()) return;   // nếu chưa có VIP NFT thì dừng
        // Chỉ chạy khi cả 2 điều kiện đều thỏa
        Debug.Log("Action executed because requirements met!");

        Debug.Log("Buying NFT Pass to Forest Guardians On Polygon");
        warningText.text = "Buying NFT Pass to Forest Guardians On Polygon";
        HideAllButtons();
        Address = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();
        CallTransfer(Address, destinationPOLY);
        ShowAllButtons();

        try
        {
            Address = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();
            var contract = ThirdwebManager.Instance.SDK.GetContract(
                smartContractAddressZETA,
                abi
            );
            // gọi hàm read
            string nftOwned = await contract.Read<string>("balanceOf", Address);
            // in ra console
            Debug.Log($"VIP NFT owned by {Address}: {nftOwned}");
            // xuất ra UI text (giả sử bạn có một Text hoặc TMP_Text tên balanceText)
            warningText.text = $"VIP NFT owned: {nftOwned}";

            //// Gọi mint
            //var writeResult = await contract.Write("safeMint", Address, uriNFT);

            //string json = JsonConvert.SerializeObject(writeResult, Formatting.Indented);
            //string tokenID = ParseJson(json);

            //try
            //{
            //    // gọi hàm read
            //    string nftOwned = await contract.Read<string>("balanceOf", Address);

            //    // in ra console
            //    Debug.Log($"VIP NFT owned by {Address}: {nftOwned}");

            //    // xuất ra UI text (giả sử bạn có một Text hoặc TMP_Text tên balanceText)
            //    warningText.text = $"VIP NFT owned: {nftOwned}";

            //    CallTransfer(tokenID, Address, destinationPOLY);
            //}
            //catch (Exception ex)
            //{
            //    Debug.LogError($"Error reading NFT balance: {ex}");
            //    warningText.text = $"Error: {ex.Message}";
            //}
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Error reading NFT balance: {ex}");
            warningText.text = $"Error: {ex.Message}";
        }
        finally
        {
            ShowAllButtons();
            warningText.text = "Please wait 3 minutes then you can play Forest Guardians On Polygon";
        }
    }

    public string serverUrl = "https://zetachain-backend-link-chain.onrender.com/transferCrossChain";

    public void CallTransfer(string receiver, string destination)
    {
        StartCoroutine(SendTransferRequest(receiver, destination));
    }

    IEnumerator SendTransferRequest(string receiver, string destination)
    {
        string jsonData = JsonUtility.ToJson(new TransferData(receiver, destination));
        var request = new UnityWebRequest(serverUrl, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("✅ Transfer success: " + request.downloadHandler.text);
            substractScore(1000);
        }
        else
        {
            Debug.LogError("❌ Request failed:");
            Debug.LogError("URL: " + request.url);
            Debug.LogError("Error: " + request.error);
            Debug.LogError("Response: " + request.downloadHandler.text);
            Debug.LogError("❌ Transfer failed: " + request.error);
        }
    }

    [System.Serializable]
    public class TransferData
    {
        public string receiver;
        public string destination;

        public TransferData(string receiver, string destination)
        {
            this.receiver = receiver;
            this.destination = destination;
        }
    }

}
