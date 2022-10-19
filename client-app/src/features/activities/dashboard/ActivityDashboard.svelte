<script>
    import ActivityList from "./ActivityList.svelte";
    import {Col, Row} from "sveltestrap";
    import ActivityDetails from "../details/ActivityDetails.svelte";
    import ActivityForm from "../form/ActivityForm.svelte";
    import {selectedActivity, activityEditMode, activitiesList} from "../../../app/stores/ActivityStores.js";
    import agent from "../../../app/api/agent.js";
    
    export let location;

    let activities = [];
    agent.Activities.list().then(response =>{
        activities = response;
    }, [])
    $:activitiesList.set(activities)
</script>
<Row>
    <Col class="col-7">
        <ActivityList/>
    </Col>
    <Col class="col-5">
        <h1>Filter</h1>
    </Col>
</Row>


