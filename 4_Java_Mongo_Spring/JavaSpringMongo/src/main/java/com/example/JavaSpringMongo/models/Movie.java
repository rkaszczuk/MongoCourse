package com.example.JavaSpringMongo.models;

import java.util.ArrayList;
import java.util.List;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.data.mongodb.core.mapping.Field;

/**
 * Created by Rafał on 2015-02-26.
 */

@Document(collection="movies")
public class Movie {
    @Id
    private String id;

    //@Field("name")
    private String name;

    @Field("gross_revenue")
    private GrossRevenue grossRevenue;

    @Field("estimated_budget")
    private EstimatedBudget estimatedBudget;
    private String type;
    private List<String> genre = new ArrayList<String>();
    private List<String> directedBy = new ArrayList<String>();
    private List<Starring> starring = new ArrayList<Starring>();
    private List<String> tagline = new ArrayList<String>();

    public GrossRevenue getGrossRevenue() {
        return grossRevenue;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public void setGrossRevenue(GrossRevenue grossRevenue) {
        this.grossRevenue = grossRevenue;
    }

    public EstimatedBudget getEstimatedBudget() {
        return estimatedBudget;
    }

    public void setEstimatedBudget(EstimatedBudget estimatedBudget) {
        this.estimatedBudget = estimatedBudget;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public List<String> getGenre() {
        return genre;
    }

    public void setGenre(List<String> genre) {
        this.genre = genre;
    }

    public List<String> getDirectedBy() {
        return directedBy;
    }

    public void setDirectedBy(List<String> directedBy) {
        this.directedBy = directedBy;
    }

    public List<Starring> getStarring() {
        return starring;
    }

    public void setStarring(List<Starring> starring) {
        this.starring = starring;
    }

    public List<String> getTagline() {
        return tagline;
    }

    public void setTagline(List<String> tagline) {
        this.tagline = tagline;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString() {
        return "Movie{" +
                "id='" + id + '\'' +
                ", name='" + name + '\'' +
                ", grossRevenue=" + grossRevenue +
                ", estimatedBudget=" + estimatedBudget +
                ", type='" + type + '\'' +
                ", genre=" + genre +
                ", directedBy=" + directedBy +
                ", starring=" + starring +
                ", tagline=" + tagline +
                '}';
    }
}
