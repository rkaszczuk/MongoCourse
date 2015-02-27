package com.example.JavaSpringMongo.repository;

import com.example.JavaSpringMongo.models.Movie;

/**
 * Created by Rafał on 2015-02-27.
 */
public interface MyMovieRepository {

    public Movie getByName(String name);
}
