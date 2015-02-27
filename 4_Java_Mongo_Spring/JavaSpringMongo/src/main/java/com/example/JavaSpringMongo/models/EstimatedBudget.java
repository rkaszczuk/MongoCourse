package com.example.JavaSpringMongo.models;

/**
 * Created by Rafał on 2015-02-26.
 */
public class EstimatedBudget {
    private Long amount;
    private String currency;

    public Long getAmount() {
        return amount;
    }

    public void setAmount(Long amount) {
        this.amount = amount;
    }

    public String getCurrency() {
        return currency;
    }

    @Override
    public String toString() {
        return "EstimatedBudget{" +
                "amount=" + amount +
                ", currency='" + currency + '\'' +
                '}';
    }

    public void setCurrency(String currency) {
        this.currency = currency;
    }
}
