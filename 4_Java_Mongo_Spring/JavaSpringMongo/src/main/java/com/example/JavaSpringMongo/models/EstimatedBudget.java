package com.example.JavaSpringMongo.models;

/**
 * Created by Rafał on 2015-02-26.
 */
public class EstimatedBudget {
    private Integer amount;
    private String currency;

    public Integer getAmount() {
        return amount;
    }

    public void setAmount(Integer amount) {
        this.amount = amount;
    }

    public String getCurrency() {
        return currency;
    }

    public void setCurrency(String currency) {
        this.currency = currency;
    }
}
