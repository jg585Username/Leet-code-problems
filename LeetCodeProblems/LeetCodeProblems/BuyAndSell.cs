namespace LeetCodeProblems;

public class BuyAndSell
{
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++){
            if (prices[i] < minPrice){
                minPrice = prices[i];
            }
            else {
                int profit = prices[i] - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
        return maxProfit;
    }
}