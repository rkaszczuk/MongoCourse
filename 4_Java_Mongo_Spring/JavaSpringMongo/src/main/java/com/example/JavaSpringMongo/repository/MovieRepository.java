package com.example.JavaSpringMongo.repository;

import com.example.JavaSpringMongo.models.Movie;
import org.springframework.data.repository.Repository;

import java.util.List;

/**
 * Created by Rafał on 2015-02-27.
 */
public interface MovieRepository  extends Repository<Movie, String>, MyMovieRepository {

    public Movie findByName(String name);

    public List<Movie> findByStarringActor(String actor);

    public List<Movie> findTop3ByEstimatedBudgetAmountGreaterThan(int value);

}
