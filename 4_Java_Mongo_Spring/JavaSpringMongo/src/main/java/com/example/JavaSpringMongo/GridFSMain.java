package com.example.JavaSpringMongo;

import com.mongodb.BasicDBObject;
import com.mongodb.DBObject;
import com.mongodb.gridfs.GridFSDBFile;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.mongodb.core.query.Criteria;
import org.springframework.data.mongodb.core.query.Query;
import org.springframework.data.mongodb.gridfs.GridFsTemplate;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.InputStream;
import java.util.List;

/**
 * Created by havi on 15.01.2016.
 */
public class GridFSMain {
    @Autowired
    private GridFsTemplate gridFsTemplate;

    public void run() throws FileNotFoundException {
        InputStream inputStream = new FileInputStream("src/main/resources/SampleVideo_720x480_2mb.mp4");
        DBObject extraData = new BasicDBObject();
        extraData.put("source", "onet");
        gridFsTemplate.store(inputStream, "video.mp4", extraData);







        /*try {
            InputStream inputStream = new FileInputStream("src/main/resources/SampleVideo_720x480_2mb.mp4");
            DBObject metaData = new BasicDBObject();
            metaData.put("source", "source1");
            gridFsTemplate.store(inputStream, "SampleVideo.mp4", "video/mp4", metaData);
        }
        catch (FileNotFoundException ex){
            System.out.println(ex.toString());
        }

        GridFSDBFile gridFSDBFiles = gridFsTemplate.findOne(new Query(Criteria.where("metadata.source").is("source1")));

        InputStream result = gridFSDBFiles.getInputStream();

        gridFsTemplate.delete(new Query(Criteria.where("filename").is("SampleVideo.mp4")));
        */
    }
}
