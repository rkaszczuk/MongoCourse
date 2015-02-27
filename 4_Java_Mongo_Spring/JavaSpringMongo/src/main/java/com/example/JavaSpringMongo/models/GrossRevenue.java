package com.example.JavaSpringMongo.models;

/**
 * Created by Rafał on 2015-02-26.
 */
public class GrossRevenue {
    public Long getAmount() {
        return amount;
    }

    @Override
    public String toString() {
        return "GrossRevenue{" +
                "amount=" + amount +
                ", currency='" + currency + '\'' +
                '}';
    }

    public void setAmount(Long amount) {
        this.amount = amount;
    }

    public String getCurrency() {
        return currency;
    }

    public void setCurrency(String currency) {
        this.currency = currency;
    }

    private Long amount;
    private String currency;

}
