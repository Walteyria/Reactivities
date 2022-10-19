<script lang="ts">
    import {Navbar, NavbarBrand, NavItem, Button, Nav, NavLink} from 'sveltestrap';
    import {activityEditMode, selectedActivity} from "../stores/ActivityStores.js";
    import {Link, Router} from "svelte-routing";
    
    
    
</script>

<Navbar dark color="primary" expand="md" fixed="top">
    <Router>
        <Link href="/" >
            <img height="32" src="/logo.png" alt="logo"/>
            <NavbarBrand>Reactivities</NavbarBrand>
        </Link>
        <Nav>
            <NavItem>
                <NavLink>
                    <Link class="text-white" to="/activities">
                        Activities
                    </Link>
                </NavLink>
            </NavItem>
            <NavItem>
                <Link to="/createActivity">
                    <Button outline color="success">Create activity</Button>
                </Link>
            </NavItem>
        </Nav>
    </Router>
</Navbar>

<style>
    img{
        margin-right: 10px;
    }
</style>